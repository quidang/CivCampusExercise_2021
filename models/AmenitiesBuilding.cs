using System.Threading;
using System.Diagnostics;
using System;
using System.Runtime.CompilerServices;
using System.Globalization;
namespace CivCampusExercise_2021.models {
    public class AmenitiesBuilding : Building {

        // Available types are: Student Amenities, Student Admin, Staff Admin, Library
        public string Type { get; set; }

        // Opening/Closing Hour in 24hr time.  example 8 = 8am, 18 = 6pm
        public int OpeningHour { get; set; }
        public int ClosingHour { get; set; }


        public AmenitiesBuilding() : base("default") {
            
        }

        //TODO: add constructor that initialises the attributes and parent constructor

        public AmenitiesBuilding(string Type, string BuildingId, int OpeningHour, int ClosingHour) : base(BuildingId) {
            this.Type = Type;
            this.OpeningHour = OpeningHour;
            this.ClosingHour = ClosingHour;
            this.BuildingId = BuildingId;
        }


        
    }
}