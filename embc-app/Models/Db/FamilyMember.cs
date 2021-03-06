namespace Gov.Jag.Embc.Public.Models.Db
{
    /// <summary>
    /// Person Database Model
    /// </summary>
    public class FamilyMember : Evacuee
    {
        public bool SameLastNameAsEvacuee { get; set; }

        // related entities
        public string RelationshipToEvacueeCode { get; set; }

        public virtual FamilyRelationshipType RelationshipToEvacuee { get; set; }

        public FamilyMember()
        {
            PersonType = Person.FAMILY_MEMBER;
        }
    }
}
