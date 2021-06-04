using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcProject.Models;
using System.Web;

namespace MvcProject.Controllers
{
    public class StatusController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public StatusController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {   
            if(GloabalVariables.NewHistory.Count()>=1){
                return View(GloabalVariables.NewHistory.ToList<StatusHistory>());
            }
            else{
                return View(ReadXML().ToList<StatusHistory>());
            }
        }

        public IActionResult Retrieve()
        {
            return PartialView("Status", ReadXML().ToList<StatusHistory>());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public List<StatusHistory> ReadXML()
        {
            System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(Status));
            System.IO.StreamReader file = new System.IO.StreamReader(
                @"status.xml");
            Status status = (Status)reader.Deserialize(file);
            file.Close();
            StatusHistory statushistory = new StatusHistory();
            statushistory.RequestDate=System.DateTime.Now;
            statushistory.status = status;
            GloabalVariables.NewHistory.Add(statushistory);
            
            return GloabalVariables.NewHistory;
            //Console.WriteLine(status.SystemUnit.ProductId);

        }
    }
}