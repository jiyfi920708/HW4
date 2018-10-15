using System;

namespace hw4
{
    public class Project
    {
       
        public int ProjectID { get; set; }         //PRMARY KEY
        public string ProjectName { get; set; }
        public string LeaderName { get; set; }
        public string ClientName { get; set; }         
        public string Deadline { get; set; } 
        public string RequiredHours { get; set; } 


    }
}