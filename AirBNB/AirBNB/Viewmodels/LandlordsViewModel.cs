using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirBNB.Classes;
using AirBNB.Viewmodels.commands;

namespace AirBNB.Viewmodels
{
    public class LandlordsViewModel
    {
        public ObservableCollection<Landlords> Landlords_collection { get; set; }
        public string Firstname_UserInput { get; set; }
        public string Lastname_userInput { get; set; }
        public int amountofhouses_UserInput { get; set; }
        public int amountofhouses { get; set; }
        public int ListViewIndexSelection { get; set; }
        public Add_Landlord_Command Add_LandlordCommand { get; set; }
        public Delete_Landlord_Command delete_LandlordCommand { get; set; }
        public Show_SpecificLandlord ShowSpecificLandlord { get; set; }
        public string Firstname_MessageBox { get; set; }
        public string Lastname_MessageBox { get; set; }

        public int Houses_messageBox { get; set; }


        public LandlordsViewModel()
        {
            hardCodeLandlords();
            Add_LandlordCommand = new Add_Landlord_Command(addUser);
            delete_LandlordCommand = new Delete_Landlord_Command(deleteUser);
            ShowSpecificLandlord = new Show_SpecificLandlord(Show_LandlordInfo);
        }


        public void hardCodeLandlords()
        {
            Landlords_collection = new ObservableCollection<Landlords>();

            Landlords landlord1 = new Landlords();
            landlord1.FirstName = "Jonna";
            landlord1.LastName = "Fraser";
            landlord1.AmountOfHouses = 2;

            Landlords landlord2 = new Landlords();
            landlord2.FirstName = "Jonathan";
            landlord2.LastName = "Kaas";
            landlord2.AmountOfHouses = 2;



            Landlords_collection.Add(landlord1);
            Landlords_collection.Add(landlord2);

        }


        public void deleteUser()
        {
            Landlords_collection.RemoveAt(ListViewIndexSelection);
            Console.WriteLine("gedelete");
        }
        public void addUser()
        {
            Landlords landlord = new Landlords();
            landlord.FirstName = Firstname_UserInput;
            landlord.LastName = Lastname_userInput;
            landlord.AmountOfHouses = amountofhouses_UserInput;

            Landlords_collection.Add(landlord);
            Console.Write("Geadd");

        }

        public void Show_LandlordInfo()
        {
            Landlords_collection[ListViewIndexSelection].FirstName = Firstname_MessageBox;
            Landlords_collection[ListViewIndexSelection].LastName = Lastname_MessageBox;
            Landlords_collection[ListViewIndexSelection].AmountOfHouses = Houses_messageBox;

            Console.WriteLine("showlandlod info word aangeroepen");
        }



        public ObservableCollection<Landlords> makeListOfLandlords(object landlord)
        {
            Landlords_collection.Add((Landlords)landlord);

            return Landlords_collection;
        }
    }
}

