using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBETA
{
    public class Zavada
    {
        private int id;
        private string category;
        private string description;

        //Nalez tabulka
        private int nalezl_id;
        private int kontrola_id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        //nalez
        public int Nalez_id
        {
            get { return nalezl_id; }
            set { nalezl_id = value; }
        }

        public int Kontrola_id
        {
            get { return kontrola_id; }
            set { kontrola_id = value; }
        }

        public Zavada(int id, string category, string description, int nalezl_id, int kontrola_id)
        {
            this.id = id;
            this.category = category;
            this.description = description;
            this.nalezl_id = nalezl_id;
            this.kontrola_id = kontrola_id;
        }
    }
}
