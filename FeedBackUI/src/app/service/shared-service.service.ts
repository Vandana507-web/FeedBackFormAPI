import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class SharedServiceService {

  constructor() { }

  public applied!:any;
  public topics! :string[]
  public softwareList :string[]=['Frontend','Backend','DataBase','CI/CD','Azure'];
  public researchList :string[]=['Areas of research','Data processing','Data analysis','People Management','Time Management'];

}
