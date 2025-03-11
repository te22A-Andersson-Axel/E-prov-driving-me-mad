string[] villains = ["DarthVader", "Magneto"];
string TheoryLessons = "1";
string DrivingLessons = "1";

DarthVader d1 = new DarthVader() {TheorySkill = 4, DrivingSkill = 8, Patience = 3};
Magneto m1 = new Magneto() {TheorySkill = 7, DrivingSkill = 5, Patience = 7};

Console.WriteLine("Welcome to the supervillain driving test game!");
while (TheoryLessons == "0" && DrivingLessons == "0")
{
    Console.WriteLine("How many Theory lessons should the participants get?: ");
    TheoryLessons = Console.ReadLine();

    Console.WriteLine("How many driving lessons should the participants get?: ");
    DrivingLessons = Console.ReadLine();
}

d1.TakeTest