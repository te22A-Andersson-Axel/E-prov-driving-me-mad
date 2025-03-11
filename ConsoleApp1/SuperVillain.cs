public class SuperVillain
{
    public string Name;
    public int TheorySkill;
    public int DrivingSkill;
    public int Patience;
    public bool HasLicense;

    public void LearnTheory()
    {
        int chance = Random.Shared.Next(1, 3);

        if (chance == 1)
        {
            Patience--;
            Console.WriteLine("You failed the Theory test!");
        }

        else if (Patience == 0)
        {
            Console.WriteLine("Your patience is at 0 :(");
        }

        else
        {
            TheorySkill++;
            Console.WriteLine("You passed The Theory test!");
        }
        //Den här delen av koden låter skurken testa att bli bättre på teori
    }

    public void LearnDriving()
    {
        int chance2 = Random.Shared.Next(1, 3);

        if (chance2 == 1)
        {
            Patience--;
            Console.WriteLine("You failed the driving test!");
        }

        else if (Patience == 0)
        {
            Console.WriteLine("Your patience is at 0 :(");
        }

        else
        {
            DrivingSkill++;
            Console.WriteLine("You passed The driving test!");
        }
        //Den här delen av koden låter skurken testa att bli bättre på att köra
    }

    public void TakeTest()
    {
        int ChanceTheory = Random.Shared.Next(TheorySkill, 11);
        int ChanceDriving = Random.Shared.Next(DrivingSkill, 11);
        if (ChanceTheory == 10 && ChanceDriving == 10)
        {
            HasLicense = true;
            Console.WriteLine("YOU GOT YOUR LICENSE!!!");
        }
        //här får skurken testa om hen klarar av att få sitt körkort

    }


}