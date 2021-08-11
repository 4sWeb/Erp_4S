import { StoreTransDetails } from "./store-trans-details";
import { StoreTransMaster } from "./store-trans-master";
import { StoreTransDep } from "./store-trans-dep";
import { StoreTransDepDetails } from "./store-trans-dep-details";

export class StoreTransMain {
  constructor(
    public stroreTransMaster?: StoreTransMaster,
    public StoreTransDep?: StoreTransDep,
    public StoreTransDepDetails?: StoreTransDepDetails[],
    public StoreTransDetails?: StoreTransDetails[]
  ) { }

}
