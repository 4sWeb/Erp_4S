import { Unites_VM } from "./Unites_VM";

export class Items_VM {
  constructor(
    public itemId?: number,
    public name?: string,
    public unites_VM?: Unites_VM[],
    public groupId?: number
  ) {

  }
}
