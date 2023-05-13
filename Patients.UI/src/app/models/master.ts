import { DataMaster } from "./dataMaster";

export interface Master {
    id: string ,
    description : string
    dataMasters?: DataMaster[]
}
