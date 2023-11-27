class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Imput Customer ID");
        Console.WriteLine("in which garage it was parked? options 1, 2 and 3");
        Console.WriteLine("How many hours of parking?");

       

        double charge;

        Park park1 = new Park(1,1,6);

        //var garage = new Park(1);


        switch (new garege())
        {
            case "1":

                if (Hours <= 3)
                {
                    Console.WriteLine($"your charge is €2.00");
                }

                else if (Hours > 3)
                {
                    for (int i = 3; i > 3; i++)
                    {
                        charge += 0.50;
                    }
                }
                else
                {
                    Console.WriteLine($"your charge is €10.00");

                }
                switch (Garage())

                {
                case "2":

                        if (Hours <= 3)
                        {
                            Console.WriteLine($"your charge is €2.00");
                        }

                        else if (Hours > 3)
                        {
                            for (int i = 3; i > 3; i++)
                            {
                                charge += 0.60;
                            }
                        }
                        else
                        {
                            Console.WriteLine($"your charge is €10.00");

                        }

                        switch (Garage())

                        {

                            case "3":

                                if (Hours <= 3)
                                {
                                    Console.WriteLine($"your charge is €2.00");
                                }

                                else if (Hours > 3)
                                {
                                    for (int i = 3; i > 3; i++)
                                    {
                                        charge += 0.75;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine($"your charge is €10.00");
                                }







                        }


                }
        }



        
    }
}