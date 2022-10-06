using BookingProject.Models;

List<Person> guests = new List<Person>();

Person Rick = new Person("Rick", "Sanchez");
Person Morty = new Person("Morty", "Smith");
Person Summer = new Person("Summer", "Smith");

guests.Add(Rick);
guests.Add(Morty);
guests.Add(Summer);

Suite premium = new Suite("Premium", 2, 20.50M);
Suite master = new Suite("Master", 3, 100.00M);


Booking familySmith = new Booking(premium, 10);
familySmith.ChangeSuite(master);
familySmith.AddGuests(guests);
familySmith.AmountToBePaid();