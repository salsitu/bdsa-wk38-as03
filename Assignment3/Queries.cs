using System;
using System.Collections.Generic;
using System.Linq;

namespace BDSA2021.Assignment03
{
    public class Queries
    {    
        public static IEnumerable<string> WizardsByRowling_LINQ()
        {
            return from w in Wizard.Wizards.Value
                   where w.Creator.Contains("Rowling")
                   select w.Name;
        }

        public static IEnumerable<string> WizardsByRowling_ExtensionMethods()
        {
            return Wizard.Wizards.Value.Where(w => w.Creator.Contains("Rowling"))
                                       .Select(w => w.Name);
        }
        
        public static int? FirstSithYear_LINQ()
        {
            return (from w in Wizard.Wizards.Value
                    where w.Name.Contains("Darth")
                    select w.Year).Min();
        }

        public static int? FirstSithYear_ExtensionMethods()
        {
            return Wizard.Wizards.Value.Where(w => w.Name.Contains("Darth"))
                                       .Select(w => w.Year).Min();
        }

        public static IEnumerable<(string, int?)> FromHarryPotter_LINQ()
        {
            return from w in Wizard.Wizards.Value
                   where w.Medium.Contains("Harry Potter")
                   select (w.Name, w.Year);
        }

        public static IEnumerable<(string, int?)> FromHarryPotter_ExtensionMethods()
        {
            return Wizard.Wizards.Value.Where(w => w.Medium.Contains("Harry Potter"))
                                       .Select(w => (w.Name, w.Year));
        }

        public static IEnumerable<string> ReverseWizardList_LINQ()
        {
            return from w in Wizard.Wizards.Value
                   orderby w.Creator descending, w.Name descending
                   select w.Name;
        }

        public static IEnumerable<string> ReverseWizardList_ExtensionMethods()
        {
            return Wizard.Wizards.Value.OrderByDescending(w => w.Creator)
                                       .ThenByDescending(w => w.Name)
                                       .Select(w => w.Name);
        }
    }
}
