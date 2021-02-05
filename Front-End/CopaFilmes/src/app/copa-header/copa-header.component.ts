import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-copa-header',
  templateUrl: './copa-header.component.html',
  styleUrls: ['./copa-header.component.css']
})
export class CopaHeaderComponent implements OnInit {
  @Input() titulo: string;
  @Input() resumo: string;

  constructor() { }

  ngOnInit(): void {
  }

}
