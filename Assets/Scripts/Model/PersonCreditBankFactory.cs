using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PersonCreditBankFactory : MonoBehaviour
{
    



    public static People GetPeople()
    {
        var people = new People
        {

        };

        var person1 = new Person
        {
            key = 10,

            lastname = "Credit Loranson",
            firstname = "Credit Clara",
            age = 104,
            accountNumber = "13132",
            amount = 120000

        };

        var person2 = new Person
        {
            key = 20,

            lastname = "Credit Tiffany",
            firstname = "Credit Peter",
            age = 14,
            accountNumber = "56565",
            amount = 20000

        };

        var person3 = new Person
        {
            key = 30,

            lastname = "Credit Longbottom",
            firstname = "Credit Mary",
            age = 20,
            accountNumber = "2732",
            amount = 29990

        };










        people.PeopleMembers.Add(person1);
        people.PeopleMembers.Add(person2);
        people.PeopleMembers.Add(person3);



        return people;
    }


}
