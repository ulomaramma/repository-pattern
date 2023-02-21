namespace WebApi.Requests
{
    
    public class RecipeRequest
    {
        public string Name { get; set; }
        public string Duration { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public int RecipeCategoryId { get; set; }
        public string Servings { get; set; }
        public string SourceUrl { get; set; }
        public string LocalUrl { get; set; }
        public int DietId { get; set; }
        public int CousineId { get; set; }
    }

}
