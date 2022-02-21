using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCS426_Lab2
{
    class Document
    {
        private String name;
        private int numberOfPages;
        private readonly DateTime createdOn;

        public Document(String newName, int newNum)
        {
            name = newName;
            numberOfPages = newNum;
            createdOn = DateTime.Now;
        }
        public override String ToString()
        {
            return "Name: " + name + ", Number of Pages: " + numberOfPages + ", Created On : " + createdOn;
        }
    }
}
