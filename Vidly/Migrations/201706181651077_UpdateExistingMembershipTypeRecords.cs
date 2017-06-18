namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateExistingMembershipTypeRecords : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipType SET Name = Pay as You Go WHERE Id = 1");
            Sql("UPDATE MembershipType SET Name = Monthly WHERE Id = 2");
        }
        
        public override void Down()
        {
        }
    }
}
