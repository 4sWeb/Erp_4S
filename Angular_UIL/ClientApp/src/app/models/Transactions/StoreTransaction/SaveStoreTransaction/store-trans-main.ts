import { storeTransDetails_VM } from "./storeTransDetails_VM";
import { storeTransMaster_VM } from "./storeTransMaster_vm";
import { storeTransDep_VM } from "./storeTransDep_VM";
import { storeTransDepDetails_VM } from "./storeTransDepDetails_VM";

export class StoreTransMain {
  constructor(
    public storeTransMaster_VM?: storeTransMaster_VM,
    public storeTransDep_VM?: storeTransDep_VM[],
    public storeTransDepDetails_VM?: storeTransDepDetails_VM[],
    public storeTransDetails_VM?: storeTransDetails_VM[]
  ) { }

}
