const puppeteer = require('puppeteer');
let adventureId = "";


describe("Adventure Journey", () => {
    let browser;
    let page;
    const url = "http://localhost:3000";
    beforeAll(async () => {
      browser = await puppeteer.launch({
        headless: false,
        devtools:false,
        slowMo:250
      });
      page = await browser.newPage();
    });

    it("Create an Adventure", async () =>{
        await page.goto(url);
        const createAdventureButton=await page.waitForSelector("#createAdventure");
        await clickButton(createAdventureButton);
        await page.waitForTimeout(1000);
        await page.waitForSelector(".question");        
    },10000);

    it("Take an Adventure", async () =>{
      await clickButton(await page.waitForSelector('button[name="YES"]'));
      await clickButton(await page.waitForSelector('button[name="YES"]'));
      await clickButton(await page.waitForSelector('button[name="Yes"]'));
      await clickButton(await page.waitForSelector('#gotomyadventure'));
    },10000);

    it("My Adventure", async () =>{
      await page.$('[name="DO I WANT A DOUGHUNT"]');
      await page.$('[name="Do I deserve it?"]');
      await page.$('[name="Are you sure?"]');
      await page.$('[name="Do jumping jacks first."]');
    },10000);
})

const clickButton = async (button) => {
  button.evaluate((b) => b.click());
};
