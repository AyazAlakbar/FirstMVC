using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Group = MVC_Task.Models.Group;

namespace MVC_Task.Controllers
{
    public class GroupController : Controller
    {
        public IActionResult Index()
        {
            return View(GetGroups());
        }

        public IActionResult Detail()
        {
         
            return View(GetGroupById(2, GetGroups()));
        }

        private List<Group> GetGroups()
        {
            Group group1 = new Group();
            group1.Id = 1;
            group1.Name = "P515";
            group1.Size = 15;

            Group group2 = new Group();
            group2.Id = 2;
            group2.Name = "P520";
            group2.Size = 20;


            Group group3 = new Group();
            group3.Id = 3;
            group3.Name = "P525";
            group3.Size = 25;

            List<Group> groups = new List<Group>();
            groups.Add(group1);
            groups.Add(group2);
            groups.Add(group3);

            return groups;
        }

        private Group GetGroupById(int id, List<Group> groups)
        {
            Group group = groups.Find(x=>x.Id == id);
            return group;
        }
    }
}
