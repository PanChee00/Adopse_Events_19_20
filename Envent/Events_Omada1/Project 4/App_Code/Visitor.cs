﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_4.App_Code.StaticMethods;
using Project_4.App_Code;
using Project_4.User_Classes.Exceptions;
using System.Windows.Controls;

namespace Project_4.User_Classes
{
    public class Visitor : User
    {

        //Μέθοδο για την εγγραφή του χρήστη
        public void signUpAsUser(UserProfile profile,string userName, string passWord,List<int> prefferences)
        {
            enventDataSetTableAdapters.userTableAdapter singUp = new enventDataSetTableAdapters.userTableAdapter();
            if (checkUserName(userName))//Έλεγχος αν υπάρχει το username ήδη .
            {
                singUp.registerAsUser(profile.GetFirstName(), profile.GetLastName(), userName, passWord, profile.GetEmail(), profile.GetAddress(), profile.GetGender(), profile.GetDob());//Η εγγραφη στη βαση
                if (prefferences.Count > 0)//Ελεγχος αν ο χρήστης συμπλήρωσε προτημίσης
                {
                    enventDataSetTableAdapters.preffered_categoriesTableAdapter prefference = new enventDataSetTableAdapters.preffered_categoriesTableAdapter();
                    int id = Convert.ToInt32(singUp.getID(userName).ToList().ElementAt(0).id);//Παίρνει το id που μόλις δημιουργήθηκε

                    foreach(int i in prefferences) // Σάρωση της λίστας με τα ενδιαφεροντα που συμπληρωσε ο χρήστης

                    {
                        prefference.insertPrefference(id, i);//Εγγραφη στη βαση
                    }
                }
            }
            else
            {
                throw new Exceptions.UserNameException("User name is already in use"); //Σε περίπτωση που το username χρησιμοποιήτε ήδη
            }
        }

        public void SingUpAsEventManager(ManagerProfile profile, string userName, string passWord)
        {//fname`, `lname`, `username`, `password`, `iban`, `email`, `address`, `dob`, `gender`
            enventDataSetTableAdapters.adminTableAdapter singUp = new enventDataSetTableAdapters.adminTableAdapter();
            if (checkUserName(userName))//Έλεγχος αν υπάρχει το username ήδη .
            {
                singUp.SignUp(profile.GetFirstName(), profile.GetLastName(), userName, passWord,profile.GetIban(), profile.GetEmail(), profile.GetAddress(),  profile.GetDob (), profile.GetGender());//Η εγγραφη στη βαση
            }
            else
            {
                throw new Exceptions.UserNameException("User name is already in use"); //Σε περίπτωση που το username χρησιμοποιήτε ήδη
            }
        }


        //Μεθοδος που ελεγχεί αν υπαρχει ο χρήστης στη βάση (Για αποφυγεί σφαλμάτων στη βαση κατα την διαδικασία του login ή οποιαδηποτε αλλη συμπεριλαμβανη τον χρήστη)
        public bool checkUserName(string userName)
        {
            enventDataSetTableAdapters.userTableAdapter checkUserName = new enventDataSetTableAdapters.userTableAdapter();
            if (Convert.ToInt32(checkUserName.checkUserName1(userName)) > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //Μέθοδος για το LogIn
        public User LogInAsNormalUser(string userName,string passWord)
        {

                enventDataSetTableAdapters.userTableAdapter tr = new enventDataSetTableAdapters.userTableAdapter();
                if (Convert.ToInt32(tr.tryLogInAsUser(userName,passWord))>0)
                {
                    InstanceOfUser.CreateCustomerUser(userName, passWord); //Δημιουργία global χρήστη τύπου normla στην στατική κλάση.
                    return InstanceOfUser.GetUser(); // Επιστροφή
                }
                else{
                    throw new Exceptions.FailLogInAsNormalUser("Λάθος στοιχεία");
                }
            }

        //Μέθοδος για το LogIn
        public User LogInAsEventManager(string userName, string passWord)
        {
            enventDataSetTableAdapters.adminTableAdapter tr = new enventDataSetTableAdapters.adminTableAdapter();
                if (Convert.ToInt32(tr.tryLogInManager(userName)) > 0)
                {
                    InstanceOfUser.CreateEventManager(userName, passWord);//Δημιουργία global χρήστη τύπου Event Manager στην στατική κλάση.
                    return InstanceOfUser.GetUser();

                } else {
                    throw new FailLoginAsEventManager("Λάθος στοιχεία");
                }
            }

        //Πρέπει να συμπληρωθεί
        public override void ShowEventDeails(int id)
        {
            throw new NotImplementedException();
        }

        public override List<Event> ShowEvents()
        {
            List<Event> events = new List<Event>();
            events = Events.events;
            return events;
        }
    }
}
