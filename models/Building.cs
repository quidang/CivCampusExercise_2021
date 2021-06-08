namespace CivCampusExercise_2021.models
{
    public class Building
    {
        public string BuildingId { get; set; }

        public Building(string buildingId)
        {
            this.BuildingId = buildingId;
        }
    }
}