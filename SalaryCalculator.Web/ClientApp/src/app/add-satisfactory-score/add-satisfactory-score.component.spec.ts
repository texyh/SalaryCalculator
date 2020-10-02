import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AddSatisfactoryScoreComponent } from './add-satisfactory-score.component';

describe('AddSatisfactoryScoreComponent', () => {
  let component: AddSatisfactoryScoreComponent;
  let fixture: ComponentFixture<AddSatisfactoryScoreComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AddSatisfactoryScoreComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AddSatisfactoryScoreComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
