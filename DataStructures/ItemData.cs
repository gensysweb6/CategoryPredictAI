using Microsoft.ML.Data;

namespace CategoryPrecdictAI.DataStructures
{
    public class ItemData
    {
        // Column 0: The item name (feature)
        [LoadColumn(0)]
        public string ItemName { get; set; }

        // Column 1: The department (label for model 1)
        [LoadColumn(1)]
        public string Department { get; set; }

        // Column 2: The category (label for model 2)
        [LoadColumn(2)]
        public string Category { get; set; }

        // Column 3: The category (label for model 3)
        [LoadColumn(3)]
        public string SubCategory { get; set; }
    }

    // Prediction class for Category
    public class CategoryPrediction
    {
        // Corresponds to the 'Category' column, but predicted
        // ML.NET automatically uses 'PredictedLabel' for the output of the trainer
        // We will use MapKeyToValue to convert the predicted key back to the original string value
        [ColumnName("PredictedCategoryValue")]
        public string PredictedCategory { get; set; }

        // (Optional) You can also get the scores for each class
         public float[] Score { get; set; }
    }


    // Prediction class for Category
    public class SubCategoryPrediction
    {
        // Corresponds to the 'SubCategory' column, but predicted
        // ML.NET automatically uses 'PredictedLabel' for the output of the trainer
        // We will use MapKeyToValue to convert the predicted key back to the original string value
        [ColumnName("PredictedSubCategoryValue")]
        public string PredictedSubCategory { get; set; }

        // (Optional) You can also get the scores for each class
        public float[] Score { get; set; }
    }

    // Prediction class for Department
    public class DepartmentPrediction
    {
        [ColumnName("PredictedDepartmentValue")]
        public string PredictedDepartment { get; set; }

        // (Optional)
         public float[] Score { get; set; }
    }

     public class CategoryProbability
    {
        public string Category { get; set; }
        public float Probability { get; set; }
    }


    public class SubCategoryProbability
    {
        public string SubCategory { get; set; }
        public float Probability { get; set; }

    }
    public class DepartmentProbability
    {
        public string Department { get; set; }
        public float Probability { get; set; }
    }
}
