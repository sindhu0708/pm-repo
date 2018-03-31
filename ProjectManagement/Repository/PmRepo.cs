using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectManagement.Models;
namespace ProjectManagement.Repository
{
    public class PmRepo
    {
        public Project GetProject()
        {
            Project p = new Project();

            p.projectCollection.Add(new tblProject { ID = 100, name = "Cerner", description = "Migration project involves lot of resources, hours and budget",
                startDate = Convert.ToDateTime("03/30/2018"), dueDate = Convert.ToDateTime("03/30/2020"),
                scope = "Migrate from Soarian to Cerner meeting specific healthcare needs" });
                                    
            p.projectCollection.Add(new tblProject{
                                        ID = 100,
                                        name = "Cerner",
                                        description = "Migration project involves lot of resources, hours and budget",
                                        startDate = Convert.ToDateTime("03/30/2018"),
                                        dueDate = Convert.ToDateTime("03/30/2020"),
                                        scope = "Migrate from Soarian to Cerner meeting specific healthcare needs"
                                    });
            
            return p;
        }

        public Project FindProject(int? id)
        {
            Project p = new Project();
            p.projectCollection.Add(new tblProject
            {
                ID = 100,
                name = "Cerner",
                description = "Migration project involves lot of resources, hours and budget",
                startDate = Convert.ToDateTime("03/30/2018"),
                dueDate = Convert.ToDateTime("03/30/2020"),
                scope = "Migrate from Soarian to Cerner meeting specific healthcare needs"
            });

            p.projectCollection.Add(new tblProject
            {
                ID = 100,
                name = "Cerner",
                description = "Migration project involves lot of resources, hours and budget",
                startDate = Convert.ToDateTime("03/30/2018"),
                dueDate = Convert.ToDateTime("03/30/2020"),
                scope = "Migrate from Soarian to Cerner meeting specific healthcare needs"
            });

            p.projectCollection.RemoveAll(item => item.ID != id);
            return p;
        }
        
    }
}