using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using samples.SignalR.Hubs;
using Microsoft.AspNetCore.Hosting;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace samples.Controllers
{
    [ApiController]
    [Route("api/general")]
    public class GeneralController : Controller
    {
        private readonly IHubContext<TasksHub> _tasksHubContext;
        public GeneralController(IHubContext<TasksHub> hubContext)
        {
            _tasksHubContext = hubContext;
        }
        // GET: GeneralController
        public ActionResult Index()
        {
            return View();
        }

        // GET: GeneralController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GeneralController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GeneralController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: GeneralController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GeneralController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: GeneralController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GeneralController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
    [ApiController]
    [Route("api/services")]
    public class ServicesController
    {
        public readonly string _rootpath;
        public ServicesController(IWebHostEnvironment env)
        {
            _rootpath = env.WebRootFileProvider.ToString();
            Trace.WriteLine(env.WebRootPath);
            Trace.WriteLine(env.WebRootFileProvider.ToString());
        }
        public HttpResponseMessage Get()
        {
            var result = new HttpResponseMessage(System.Net.HttpStatusCode.OK);
            string path = @"C:\Users\ljudm\source\repos\samples\Files\1.xlsx";
            string path2 = Directory.GetCurrentDirectory() + @"\1.xlsx";
            //Trace.WriteLine(path);
            //Trace.WriteLine(path2);
            Trace.WriteLine(_rootpath);
            //string locationfolder = HttpContext.Current.Server.MapPath("~/Files");
            try
            {
                var stream = new FileStream(path, FileMode.Open, FileAccess.Read);
                result.Content = new StreamContent(stream);
                // result.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/xlsx");
                result.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/octet-stream");
                var value = new System.Net.Http.Headers.ContentDispositionHeaderValue("attachment");
                byte[] bytes = System.IO.File.ReadAllBytes(path);
                
                value.FileName = "1.xlsx";
                result.Content.Headers.ContentDisposition = value;
                return result; 
                // return File(bytes, "application/octet-stream", "1.xlsx");
                // window.open("downloadPage.php");
            }
            catch (Exception e)
            {
                Trace.WriteLine(e.Message);
                result = new HttpResponseMessage(System.Net.HttpStatusCode.InternalServerError);
            }
            return result;
        }
    }
}
