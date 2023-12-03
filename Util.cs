// Import correct packages
using System;
using System.IO;
using System.Collections.Generic;

// generates csv file
// StreamWriter file = new StreamWriter("data/employees.csv");


namespace CatWorx.BadgeMaker
{

        class Util 
        {

                public static void PrintEmployees(List<Employee> employees)
                {
                        for (int i = 0; i < employees.Count; i++)
                        {
                                
                                string template = "{0,-10}\t{1,-20}\t{2}";
                                Console.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetFullName(), employees[i].GetPhotoUrl()));
                        }
                }

                public static void MakeCSV(List<Employee> employees)
                {
                        if (!Directory.Exists("data"))
                        {
                                Directory.CreateDirectory("data");
                        }

                        // inputs info into csv file
                        using (StreamWriter file = new StreamWriter("data/employees.csv"))
                        {
                                file.WriteLine("ID,Name,PhotoUrl");

                                for (int i = 0; i < employees.Count; i++)
                                {
                                        string template = "{0},{1},{2}";
                                        file.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetFullName(), employees[i].GetPhotoUrl()));
                                }
                        }
                                        }
                                }

                        }


// using System.Net.Http;
// using SkiaSharp;
// using System.Threading.Tasks;

// Method declared as "static"
        // public static void PrintEmployees()
        // {

        // }
        // Add list parameter to method
        // public static void PrintEmployees(List<Employee> employees)
        // {
        //     for (int i = 0; i < employees.Count; i++) 
        //     {
        //         string template = "{0,-10}\t{1,-20}\t{2}";
        //         file.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetFullName(), employees[i].GetPhotoUrl()));

        //     }
        // }

        // public static void MakeCSV(List<Employee> employees)
        // {
        //     // check to see if folder exists
        //     if (!Directory.Exists("data"))
        //     {
        //         // if not, create it
        //         Directory.CreateDirectory("data");
        //     }
        // }
    
        // async public static Task MakeBadges(List<Employee> employees) {
        //     // Create image
        //     SKImage newImage = SKImage.FromEncodedData(File.OpenRead("badge.png"));
        //     // encode our SKImage into the image format that we want
        //     SKData data = newImage.Encode();
        //     // allow us to save it to a file.
        //     data.SaveTo(File.OpenWrite("data/employeeBadge.png"));
            
        //     // Layout variables
        //     int BADGE_WIDTH = 669;
        //     int BADGE_HEIGHT = 1044;

        //     int PHOTO_LEFT_X = 184;
        //     int PHOTO_TOP_Y = 215;
        //     int PHOTO_RIGHT_X = 486;
        //     int PHOTO_BOTTOM_Y = 517;

        //     int COMPANY_NAME_Y = 150;

        //     int EMPLOYEE_NAME_Y = 600;

        //     int EMPLOYEE_ID_Y = 730;


        //     // instance of HttpClient is disposed after code in the block has run
        //     using(HttpClient client = new HttpClient())
        //     {
        //         for (int i = 0; i < employees.Count; i++)
        //         {
        //             SKImage photo = SKImage.FromEncodedData(await client.GetStreamAsync(employees[i].GetPhotoUrl()));
        //             SKImage background = SKImage.FromEncodedData(File.OpenRead("badge.png"));
                    
        //             SKBitmap badge = new SKBitmap(BADGE_WIDTH, BADGE_HEIGHT);
        //             // method allows usnto insert images onto the badge.
        //             SKCanvas canvas = new SKCanvas(badge);
        //             // allocate a position and size on the badge.
        //             canvas.DrawImage(background, new SKRect(0, 0, BADGE_WIDTH, BADGE_HEIGHT));
        //             canvas.DrawImage(photo, new SKRect(PHOTO_LEFT_X, PHOTO_TOP_Y, PHOTO_RIGHT_X, PHOTO_BOTTOM_Y));


        //             // SKData data = photo.Encode();
        //             SKImage finalImage = SKImage.FromBitmap(badge);
        //             SKData data = finalImage.Encode();
        //             data.SaveTo(File.OpenWrite("data/employeeBadge.png"));
                    

        //             SKPaint paint = new SKPaint();
        //             paint.TextSize = 42.0f;
        //             paint.IsAntialias = true;
        //             paint.Color = SKColors.White;
        //             paint.IsStroke = false;
        //             paint.TextAlign = SKTextAlign.Center;
        //             paint.Typeface = SKTypeface.FromFamilyName("Arial");
                    
        //             // Company name
        //             canvas.DrawText(employees[i].GetCompanyName(), BADGE_WIDTH / 2f, COMPANY_NAME_Y, paint);

        //             paint.Color = SKColors.Black;

        //             // Employee name
        //             canvas.DrawText(employees[i].GetFullName(), BADGE_WIDTH / 2f, EMPLOYEE_NAME_Y, paint);
                
        //         paint.Typeface = SKTypeface.FromFamilyName("Courier New");

        //         // Employee ID
        //         canvas.DrawText(employees[i].GetId().ToString(), BADGE_WIDTH / 2f, EMPLOYEE_ID_Y, paint);
                                
                
        //         string template = "data/{0}_badge.png";
        //         data.SaveTo(File.OpenWrite(string.Format(template, employees[i].GetId())));
                
                
                
        //         }
        //     }

        // }

        

//     }