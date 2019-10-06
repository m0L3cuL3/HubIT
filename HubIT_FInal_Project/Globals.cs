using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubIT_FInal_Project
{
    /// <summary>
    /// This purpose of this class is to create
    /// a default values for the classes that needed them.
    /// </summary>
    class Globals
    {

        // category for all file extensions.
        public string[] extension_category =
        {
            ".doc",
            ".docx",
            ".txt",
            ".pdf",
            ".java",
            ".py",
            ".cpp",
            ".c"
        };

        // category for all programming languages.
        public string[] programming_category = 
        {
            "None",
            "Java",
            "Python",
            "C++",
            "C#"
        };

        // category for all topics.
        public string[] topic_category =
        {
            "None",
            "Inheritance",
            "Abstraction",
            "If-Else statements",
            "Loops",
            "Arrays",
            "Declaring variables"
        };

    }
}
