using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// Represents a specific unit that the ACS User will interact with
    /// </summary>
    public class AccessControlElement
    {
        private int id;
        private string description;
        private string location;

        /// <summary>
        /// Generic Constructor for a Access Control Element
        /// </summary>
        public AccessControlElement()
        {

        }

        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

    }
}
