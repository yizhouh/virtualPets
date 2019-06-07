namespace cs_VirtualPets
{
    interface IPets
    {
        string PetName { get; }
        double RelationToMaster {get;}
        string HappySound {get;}
        string SadSound {get;}

        //if master's relation amount to pet greater than 0.7, pet would respond, otherwise no respond.
        bool RespondToCall(PetMaster master);

        //respond by touching your pet should call happy sound
        //increase the relationship
        void RespondByTouch();

        //complain when pet needs care
        //decrease the relationship
        void Complain();

        //print the relationship amount
        void PrintTheRelationship();

    }
}