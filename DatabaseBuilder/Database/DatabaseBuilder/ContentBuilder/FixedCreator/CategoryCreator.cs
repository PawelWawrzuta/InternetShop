﻿using System;
using DatabaseBuilder.Entities;
using System.Collections.Generic;

namespace DatabaseBuilder.FixedCreator
{
    /// <summary>
    /// Builds a fixed table of type Category
    /// </summary>
    public class CategoryCreator : IFix
    {
        public CategoryCreator(ref MyContext context)
        {
            __Context = context;
        }

        private MyContext __Context = new MyContext("");
        private List<Category> Categories = new List<Category>()
        {
            new Category(){CategoryID = 1, CategoryName = "CPUs", CategoryDescription = "Central Processing Unit - electronic circuitry that executes instructions comprising a computer program. The CPU performs basic arithmetic, logic, controlling, and input/output operations specified by the instructions in the program."},
            new Category(){CategoryID = 2, CategoryName = "GPUs", CategoryDescription = "Graphics Processing Unit - specialized electronic circuit designed to rapidly manipulate and alter memory to accelerate the creation of images in a frame buffer intended for output to a display device."},
            new Category(){CategoryID = 3, CategoryName = "Motherboards", CategoryDescription = "The main printed circuit board in a complex electronic device, such as a personal computer, usually containing the central processing unit, the main system memory, and other components essential to the device's operation."},
            new Category(){CategoryID = 4, CategoryName = "RAM", CategoryDescription = " More RAM memory means faster processing speeds, which means faster loading times, improved 3D rendering and smoother operation while running multiple programs."},
            new Category(){CategoryID = 5, CategoryName = "HDD", CategoryDescription = "A HDD or hard disk drive is an electro-mechanical data storage device that stores and retrieves digital data using magnetic storage and one or more rigid rapidly rotating platters coated with magnetic material."},
            new Category(){CategoryID = 6, CategoryName = "SSD", CategoryDescription = "A SSD or solid-state drive is a solid-state storage device that uses integrated circuit assemblies to store data persistently, typically using flash memory, and functioning as secondary storage in the hierarchy of computer storage."},
            new Category(){CategoryID = 7, CategoryName = "Computer Cooling", CategoryDescription = "Computer cooling is required to remove the waste heat produced by computer components, to keep components within permissible operating temperature limits."},
            new Category(){CategoryID = 8, CategoryName = "Power Supply", CategoryDescription = "A power supply unit converts mains AC to low-voltage regulated DC power for the internal components of a computer."},
            new Category(){CategoryID = 9, CategoryName = "Computer Cases", CategoryDescription = "A computer case is the enclosure that contains most of the components of a personal computer. Cases are usually constructed from steel, aluminium and plastic."},
            new Category(){CategoryID = 10, CategoryName = "Speakers", CategoryDescription = ""},
            new Category(){CategoryID = 11, CategoryName = "Headphones", CategoryDescription = ""},
            new Category(){CategoryID = 12, CategoryName = "Mice", CategoryDescription = "A computer mouse is a hand-held pointing device that detects two-dimensional motion relative to a surface."},
            new Category(){CategoryID = 13, CategoryName = "Keyboards", CategoryDescription = ""},
            new Category(){CategoryID = 14, CategoryName = "Monitors", CategoryDescription = "A monitor is a piece of computer hardware that displays the video and graphics information generated by a connected computer through the computer's video card."}
        };

        //can it add IDs despite using a counter type?

        public bool SaveToDatabaseSequentially()
        {
            foreach(Category category in Categories)
            {

                __Context.Category.Add(category);
                if(!(__Context.SaveChanges() == 1))
                {
                    Console.WriteLine($"An error occured while trying to save a Category type into the DB\nCategory ID = {category.CategoryID}");
                }
            }

            return true;
        }
    }
}
