export class Users_VM {

  constructor
    (
        public   Userid      ?:number,
        public   Usercode    ? :string,
        public   Username    ? :string,
        public   Userename   ? :string,
        public   Userpassword? :string,
        public   Positionapps? :string,
        public   Active      ?:number,
        public   Createdate  ? :Date,
        public   UsergroupId ? :number,
        public   Projectno  ?:number,
        public   Privilegeid?:number,
        public Salt?: string,
        public Uname?: string   
     )
  {

  }
}
