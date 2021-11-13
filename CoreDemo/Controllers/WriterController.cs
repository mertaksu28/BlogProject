using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using CoreDemo.Models;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;

namespace CoreDemo.Controllers
{
    public class WriterController : Controller
    {

        WriterManager writerManager = new WriterManager(new EfWriterRepository());

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult WriterProfile()
        {
            return View();
        }

        public IActionResult WriterMail()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult Test()
        {
            return View();
        }

        [AllowAnonymous]
        public PartialViewResult WriterNavbarPartial()
        {
            return PartialView();
        }

        [AllowAnonymous]
        public PartialViewResult WriterFooterPartial()
        {
            return PartialView();
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult WriterEditProfile()
        {
            var writerValues = writerManager.GetById(1);
            return View(writerValues);
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult WriterEditProfile(Writer writer)
        {
            WriterValidator writerValidator = new WriterValidator();
            ValidationResult validationResult = writerValidator.Validate(writer);
            if (validationResult.IsValid)
            {
                writerManager.Update(writer);
                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult WriterAdd()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult WriterAdd(AddProfileImage profileImage)
        {
            Writer writer = new Writer();
            if (profileImage.WiterImageFile != null)
            {
                var extension = Path.GetExtension(profileImage.WiterImageFile.FileName);//Girilen resim dosyasının dosya adı
                var newImageName = Guid.NewGuid() + extension;
                var saveToPlace = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/WriterImageFiles", newImageName);
                using (var stream = new FileStream(saveToPlace, FileMode.Create))
                {
                    profileImage.WiterImageFile.CopyTo(stream);
                };
                writer.WiterImage = newImageName;
            }
            writer.WriterId = profileImage.WriterId;
            writer.WriterName = profileImage.WriterName;
            writer.WriterAbout = profileImage.WriterAbout;
            writer.Email = profileImage.Email;
            writer.Status = true;
            writer.Password = profileImage.Password;
            writer.WriterPasswordAgain = profileImage.WriterPasswordAgain;

            writerManager.Add(writer);
            return RedirectToAction("Index", "Dashboard");
        }

    }
}
