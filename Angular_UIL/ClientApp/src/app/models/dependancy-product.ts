export class DependancyProduct {
  constructor(public Item_ID?: number,
    public Item_Name?: string,
    public Quantity?: number,
    public Price?: number,
    public Value?: number,
    public Unit_ID?: number,
    public Unit_Name?: string,
    public Tax_Rate?: number,
    public Tax_Value?: number,
    public Disc_Rate?: number,
    public Disc_Value?: number,
    public Profit_Tax_Rate?: number,
    public Profit_Tax_Value?: number,
    public Net_Value?: number,
    public Store_Trns_M_ID?: number,
    public Note?: string,
    public StoreTrnsOID?: number
  ) {

  }
}
