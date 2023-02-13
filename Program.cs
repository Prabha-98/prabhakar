int experiance, age;
string degree, masterdegree, gender;

Console.WriteLine("enter male or female");
gender = Console.ReadLine();

if (gender.Trim().ToLower().Equals("male"))
{

    Console.WriteLine("DO you have degree yes/no");
    degree = Console.ReadLine();


    if (degree.Trim().ToLower().Equals("yes"))
    {
        Console.WriteLine("enter the age");
        age = Convert.ToInt32(Console.ReadLine());

        if (age > 18 && age < 35)
        {
            Console.WriteLine("enter the experiance");
            experiance = Convert.ToInt32(Console.ReadLine());

            if (experiance <= 5)
            {
                Console.WriteLine("DO you have masterdegree yes/no");
                masterdegree = Console.ReadLine();

                if (masterdegree.Trim().ToLower().Equals("yes") && experiance <= 1)
                {
                    Console.WriteLine("YOU ARE SELECTED");
                }
                else
                {
                    Console.WriteLine("YOU AER NOT SELECTED FOR NOT HAVING MASTER AND 1 LESS YEAR");
                }

            }
            else
            {
                Console.WriteLine("not selectred becz of exper");
            }


        }
        else
        {
            Console.WriteLine("not selectred becz of age");
        }

    }
    else
    {
        Console.WriteLine("not selectred becz of degree");
    }
}
else
{
    Console.WriteLine("DO you have degree yes/no");
    degree = Console.ReadLine();


    if (degree.Trim().ToLower().Equals("yes"))
    {
        Console.WriteLine("enter the age");
        age = Convert.ToInt32(Console.ReadLine());

        if (age > 20 && age < 35)
        {
            Console.WriteLine("enter the experiance");
            experiance = Convert.ToInt32(Console.ReadLine());

            if (experiance <= 4)
            {
                Console.WriteLine("YOU ARE SELECTED");

            }
            else
            {
                Console.WriteLine("YOU AER NOT SELECTED FOR expe");
            }

        }
        else
        {
            Console.WriteLine("not selectred becz of age");
        }


    }
    else
    {
        Console.WriteLine("not selectred becz of degree");
    }
}




        