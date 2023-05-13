export interface ResponseMode<T>{
    isOk : boolean,
    message : string,
    exception : string,
    data : T
}