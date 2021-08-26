
import { AllTransactions } from "../AllStoreTransacion/all-transactions";
import { TransactionsName } from "./transactions-name";

export class TransactionDepSpec_VM {
  constructor(
    public TrnsList?: AllTransactions[],
    public TransactionsNames?: TransactionsName[],
  ) { }
}
