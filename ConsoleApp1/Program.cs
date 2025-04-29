string[] villains = ["DarthVader", "Magneto"];
string TheoryLessons = "1";
string DrivingLessons = "1";
int resultTheory = 1;
int resultDriving = 1;
bool success = false;
bool success2 = false;

DarthVader d1 = new DarthVader() {TheorySkill = 4, DrivingSkill = 8, Patience = 3};
Magneto m1 = new Magneto() {TheorySkill = 7, DrivingSkill = 5, Patience = 7};

Console.WriteLine("Welcome to the supervillain driving test game!");
while (success == false || success2 == false)
{
    Console.WriteLine("How many Theory lessons should the participants get?: ");
    TheoryLessons = Console.ReadLine();
    success = int.TryParse(TheoryLessons, out resultTheory);
    if (success == false)
    {
        Console.WriteLine("That's not a number try again!");
    }


    Console.WriteLine("How many driving lessons should the participants get?: ");
    DrivingLessons = Console.ReadLine();
    success2 = int.TryParse(DrivingLessons, out resultDriving);
    if (success2 == false)
    {
        Console.WriteLine("That's not a number try again!");
    }

}

for (int i = 0; i < resultTheory; i++)
{
    d1.LearnTheory();
    m1.LearnTheory();
}

for (int i = 0; 1 < resultTheory; i++)
{
    d1.LearnDriving();
    m1.LearnDriving();
}
