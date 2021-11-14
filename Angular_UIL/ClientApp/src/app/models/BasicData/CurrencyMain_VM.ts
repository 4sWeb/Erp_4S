import { CurrencyMaster_VM } from "./CurrencyMaster_VM";
import { CurrencyRates_VM } from "./CurrencyRates_VM";

export class CurrencyMain_VM {

  constructor
    (
    public CurrencyMaster_VM: CurrencyMaster_VM,
    public CurrencyRates_VM: CurrencyRates_VM[],
    public UpdateType?: string

    ) { }
}
