import { storeTransDetails_VM } from "./storeTransDetails_VM";
import { storeTransMaster_VM } from "./storeTransMaster_vm";
import { storeTransDep_VM } from "./storeTransDep_VM";
import { storeTransDepDetails_VM } from "./storeTransDepDetails_VM";

export class StoreTransMain {
  constructor(
    public StoreTransMaster_VM?: storeTransMaster_VM,
    public StoreTransDep_VM?: storeTransDep_VM[],
    public StoreTransDepDetails_VM?: storeTransDepDetails_VM[],
    public StoreTransDetails_VM?: storeTransDetails_VM[],
    public IsDependant?: boolean
  ) { }

}
