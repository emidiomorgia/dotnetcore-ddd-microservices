import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ValueItem } from './value-item';

@Component({
  selector: 'app-connection-demo',
  templateUrl: './connection-demo.component.html',
  styleUrls: ['./connection-demo.component.css']
})
export class ConnectionDemoComponent implements OnInit {

  public response : string='';
  constructor(private httpClient : HttpClient) { }

  ngOnInit() {
  }

  public loadData(){
    this.httpClient.get<ValueItem>('https://localhost:7249/Values/1').subscribe(resp => {
      this.response=resp.id + ', ' + resp.value;
    });
  }

}
