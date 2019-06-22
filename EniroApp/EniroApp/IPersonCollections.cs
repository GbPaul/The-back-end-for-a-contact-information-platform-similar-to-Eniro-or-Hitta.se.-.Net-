namespace EniroApp
{
    public interface IPersonCollections
    {
        void CreateUser(Person user);
        void DeleteUser(Person per);
        int GetNumberOfEntries();
        Person RetrieveByPersonalId(string per);
        void UpdateUser(Person per);
    }
}