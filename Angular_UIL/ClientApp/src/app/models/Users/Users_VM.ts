export class Users_VM {

  constructor
    (
        public   userid      ?:number,
        public   usercode    ? :string,
        public   username    ? :string,
        public   userename   ? :string,
        public   userpassword? :string,
        public   positionapps? :string,
        public   active      ?:number,
        public   createdate  ? :Date,
        public   usergroupId ? :number,
        public   projectno  ?:number,
        public   privilegeid?:number,
        public salt?: string,
        public uname?: string   
     )
  {

  }
}
