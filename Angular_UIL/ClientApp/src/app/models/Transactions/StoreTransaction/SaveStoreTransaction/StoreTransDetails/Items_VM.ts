import { Unites_VM } from "./Unites_VM";

export class Items_VM {
  constructor(
    public GROUP_ID?: number,
    public ITEM_ID?: number,
    public ITEM_CODE?: string,
    public ITEM_NAME?: string,
    public BASIC_UNIT?: number,
    public UNIT_RATE?: number
  ) {

  }
}
