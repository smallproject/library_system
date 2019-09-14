namespace Library_system.Database.UnitOfWork
{

    //this is a global interface with basic function
    interface IBase
    {
        bool Create();
        bool Update();
        bool Delete();
    }
}
