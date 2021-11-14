export class CurrencyMaster_VM {

  constructor
    (

      public Aname:string,
      public Ename:string,
      public Shortname :string,
      public Isdefault :string,
      public AcurrUnit1:string,
      public AcurrUnit2:string,
      public AcurrUnit3:string,
      public AcurrUnit4:string,
      public AfracUnit1:string,
      public AfracUnit2:string,
      public AfracUnit3:string,
      public AfracUnit4:string,
      public EcurrUnit1:string,
      public EcurrUnit2:string,
      public EcurrUnit3:string,
      public EcurrUnit4:string,
      public EfracUnit1:string,
      public EfracUnit2:string,
      public EfracUnit3:string,
      public EfracUnit4: string,
      public Id: number,
      public AlreadyUsed?: boolean,

    ) { }
}
