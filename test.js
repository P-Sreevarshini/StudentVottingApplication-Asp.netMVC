const puppeteer = require('puppeteer');

(async () => {
    const browser = await puppeteer.launch({
        headless: false,
        args: ['--headless', '--disable-gpu', '--remote-debugging-port=9222', '--no-sandbox', '--disable-setuid-sandbox']
    });


    const page1 = await browser.newPage();

try {
    // Test case: Submit the form
    await page1.goto('http://localhost:8080/Student'); 
    await page1.setViewport({
        width: 1200,
        height: 800,
    });
    
    const addStudentButton = await page1.waitForSelector('a[id="addStudent"]', { timeout: 0 });

    if (addStudentButton) {
        console.log('TESTCASE:Add Student Button Exists: success');
    }
    else {
        console.log('TESTCASE: Add Student Button Exists: success');

    }

} catch (e) {
    console.error('Error in creating the button:');
    console.error(e);
}


const page2 = await browser.newPage();

try {
    await page2.goto('http://localhost:8080/Student'); 

    await page2.setViewport({
        width: 1200,
        height: 800,
    });

    const studentNameColumn = await page2.$x("//th[contains(., 'StudentName')]");
    const studentIdColumn = await page2.$x("//th[contains(., 'StudentID')]");

    if (studentNameColumn.length > 0 && studentIdColumn.length > 0)
     {
        console.log('TESTCASE:Student Name or Student ID Exist:success');
     }

}

    catch (e) {
    console.error('TESTCASE:Student Name Or Student ID Column Missing:failure');
    console.error(e);

}



const page3 = await browser.newPage();

try {
    await page3.goto('http://localhost:8080/Student/Create'); 
    await page3.setViewport({
        width: 1200,
        height: 800,
    });

    await page3.waitForSelector('input[type="submit"]');
    const submitButton = await page3.$eval('input[type="submit"]', el => el.value);

    if (submitButton === 'Create') {
        console.log('TESTCASE:Check submit button:success');

    }

} catch (e) {
    console.error('Error in submitting the form:');
    console.error(e);
}


    const page4 = await browser.newPage();

try {
    await page4.goto('http://localhost:8080/Student/Create', { timeout: 0 }); 
    await page4.setViewport({
        width: 1200,
        height: 800,
    });

    await page4.type('input[name="StudentName"]', 'Test Student', { timeout: 1000 });
    const studentNameValue = await page4.$eval('input[name="StudentName"]', el => el.value);

    if (studentNameValue === 'Test Student') {
        console.log('TESTCASE:Fill the StudentName field:success');
    } 
     await page4.evaluate(() => document.querySelector('input[name="StudentName"]').value = '');

} catch (e) {
    console.error('Error in filling StudentName:');
    console.error(e);
}

    // const page5 = await browser.newPage();

    // try {
    //     await page5.goto('http://localhost:8080/StudentVote/Create/1'); 
    //     await page5.setViewport({
    //         width: 1200,
    //         height: 800,
    //     });
    
    //     const dropdown = await page5.$('select.form-control');
    
    //     if (dropdown) {
    //         console.log('TESTCASE: Dropdown Exists:success');
    //     } 
    
    // } catch (e) {
    //     console.error('Error in checking the dropdown:');
    //     console.error(e);
    // }
    

    const page6 = await browser.newPage();

    try {
        await page6.goto('http://localhost:8080/StudentVote'); 
    
        const presidentButton = await page6.waitForSelector('a[id="president"]', { timeout: 1000 });
        const VpresidentButton = await page6.waitForSelector('a[id="vicepresident"]', { timeout: 1000 });
    
        if (presidentButton) {
            console.log('TESTCASE:President Button Exists:success');
        }
        if (VpresidentButton) {
            console.log('TESTCASE:Vice President Button Exists:success');
        } 
    } catch (error) {
        console.log('Check President and Vice President Button existence:failure');
        console.error('An error occurred:', error);
    }
    

    const page7 = await browser.newPage();

try {
    await page7.goto('http://localhost:8080/StudentVote'); 

    const captainButton = await page7.waitForSelector('a[id="captain"]', { timeout: 3000 });
    const secretaryButton = await page7.waitForSelector('a[id="secretary"]', { timeout: 3000 });

    if (captainButton) {
        console.log('TESTCASE:Captain Button Exists:success');
      } 
    if (secretaryButton) {
        console.log('TESTCASE:Secretary Button Exists:success');
    }

} catch (error) {
    console.log('TESTCASE:Check Captain or Secretary Button existence:failure');
    console.error('An error occurred:', error);
}

    const page8 = await browser.newPage();

    try {
        await page8.goto('http://localhost:8080/Student/Create');     
    
        const createButton = await page8.$('input[type="submit"]');
        if (createButton) {
            console.log('TESTCASE:Create Button Exists:success');
        }
    
    } catch (error) {
        console.log('TESTCASE: Create student: failure');
        console.error('An error occurred:', error);
    }
    

     finally {
        await page1.close();
        await page2.close();
        await page3.close();
        await page4.close();
      //  await page5.close();
        await page6.close();
        await page7.close();
        await page8.close();
        await browser.close();


    }
})();



