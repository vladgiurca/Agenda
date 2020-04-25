using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.BL
{
    public class Activity
    {
        // fiecare activitatate este definita de nume, descriere, data ora incepere, data ora sfarsit (data si ora = an, luna, zi, ora, minut) si optional alti participanti la activitate (in cazul in care sunt si alti participanti activitatea va fi adaugata si in calendarul lor)
        private string name;
        private string description;
        private DateTime startDate;
        // private DateTime stopDate;
        // private string members; // lista sau array

        public Activity(string name, string description, DateTime startDate /* members*/ )
        {
            this.name = name;
            this.description = description;
            this.startDate = startDate;
            // this.members = members;
        }

        
    }
}
