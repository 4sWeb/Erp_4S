import { AllTransactions } from "./all-transactions";
import { TransactionsName } from "./transactions-name";

export class TransactionDepSpec {
  constructor(
    public TrnsList?: AllTransactions[],
    public TransactionsNames?: TransactionsName[],
  ) { }
}
