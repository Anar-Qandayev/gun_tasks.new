﻿using System;

namespace Gun.Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Tutumu daxil edin: ");
            int bulletCapacity = Convert.ToInt32(Console.ReadLine());
            Console.Write("Gulle sayini daxil edin: ");
            int bulletCount = Convert.ToInt32(Console.ReadLine());
            Console.Write("Daragin bosalma vaxtini saniye ile daxil edin: ");
            int bulletShootSecond = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ates modunu daxil edin: (1-> Tekli mode ve ya 2-> Avtomatik mode): ");
            int shootMode = Convert.ToInt32(Console.ReadLine());

            Weapon we = new Weapon(bulletCapacity, bulletCount, bulletShootSecond, shootMode);


            int key = 0;
            do
            {
                Console.WriteLine("0 - İnformasiya almaq üçün"+"\n" +
                                   "1 - Shoot metodu üçün" + "\n" +
                                   "2 - Fire metodu üçün" + "\n" +
                                   "3 - GetRemainBulletCount metodu üçün" + "\n" +
                                   "4 - Reload metodu üçün" + "\n" +
                                   "5 - ChangeFireMode metodu üçün" + "\n" +
                                   "6 - Proqramdan dayandırmaq üçün" + "\n" +
                                   "7 - Redakte et \n");
                Console.Write("Reqem daxil edin : ");
                key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        Console.WriteLine("1ci metod");
                        we.Shoot();
                        break;
                    case 2:
                        Console.WriteLine("2ci metod");
                        int fire = we.Fire();
                        if (fire > 0)
                        {
                            Console.WriteLine("Daraqdaki butun gulleler atildi ve bu proses " + fire + " saniye davam etdi");
                        }
                        else
                        {
                            Console.WriteLine("Daraqda ates achmaq uchun gulle yoxdur.\n");
                        }

                        break;
                    case 3:
                        Console.WriteLine("3cu metod");
                        
                        if (we.GetRemainBulletCount() == 0)
                        {
                            Console.WriteLine("Daraqdaki gulle sayi maksimumdur");
                        }
                        else if (we.GetRemainBulletCount() > 0)
                        {
                            Console.WriteLine("Darağın tam dolması üçün " + we.GetRemainBulletCount() + " gulle lazimdir");
                        }
                        break;
                    case 4:
                        Console.WriteLine("4cu metod");
                        we.Reload();
                        Console.WriteLine("Daraq Reload olundu, Daraqdaki gulle sayi maksimumdur");
                        break;
                    case 5:
                        Console.WriteLine("5ci  metod");
                        we.ChangeFireMode();
                        break;
                    case 6:
                        Console.WriteLine("Sagolun");
                        break;
                    case 7:
                        Console.WriteLine("7ci metod");
                        we.Edit();
                        break;
                    case 0:
                        Console.WriteLine("0ci  metod");
                        Console.WriteLine("Daragin tutumu -> " + we.bulletCapacity);
                        Console.WriteLine("Daraqdaki gulle sayi -> " + we.bulletCount);
                        Console.WriteLine("Darağın boşalma saniyesi -> " + we.bulletShootSecond);
                        Console.WriteLine("Atish modu -> " + we.shootMode);
                        break;
                    default:
                        Console.WriteLine("Yanlis daxil etdiniz");
                        break;
                }
            } while (key != 6);




        }
    }
}
