namespace BusinessLayer
{
    public class BusinessClass
    {
        //Data Layer Object
        DataAccessLayer.DataClass DataObject = new DataAccessLayer.DataClass();

        //Creating an issue
        public void CreateIssue(string location, string category, string description, string image)
        {
            DataObject.CreateIssue(location, category, description, image);
        }
    }
}
