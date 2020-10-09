namespace vid3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateBirthdateToCustomers : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate='1984-02-10' WHERE Id=1");
            Sql("UPDATE Customers SET Birthdate='1988-03-15' WHERE Id=2");
        }
        
        public override void Down()
        {
        }
    }
}
