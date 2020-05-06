using System;

namespace PortfolioII.Models
{
    public class Project {

        public string Name;
        public string ImageLink;
        public string Description;


        public Project(string name, string imgLink, string desc){
            Name = name;
            ImageLink = imgLink;
            Description = desc;
        }
    }
}