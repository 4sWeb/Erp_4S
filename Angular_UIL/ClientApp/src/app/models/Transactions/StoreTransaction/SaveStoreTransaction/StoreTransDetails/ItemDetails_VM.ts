import { Items_VM } from "./Items_VM";
import { Unites_VM } from "./Unites_VM";

export class ItemDetails_VM {
  constructor(
    public Items_VMs?: Items_VM[],
    public Unites_VMs?: Unites_VM[],
    public Price?: number,
  ) {

  }
}
