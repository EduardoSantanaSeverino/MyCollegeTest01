import { MyCollegeTemplatePage } from './app.po';

describe('MyCollege App', function() {
  let page: MyCollegeTemplatePage;

  beforeEach(() => {
    page = new MyCollegeTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
