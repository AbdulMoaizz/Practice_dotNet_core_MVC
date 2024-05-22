from selenium import webdriver
from selenium.webdriver.chrome.service import Service
from selenium.webdriver.common.by import By
from selenium.webdriver.support.ui import Select
from selenium.webdriver.common.keys import Keys
import time

service = Service(executable_payh="chromedriver.exe")
driver = webdriver.Chrome(service=service)

driver.get("https://localhost:7014/")

element = driver.find_element(By.LINK_TEXT, "Create")
element.send_keys(Keys.ENTER)
time.sleep(1)
input_element = driver.find_element(By.ID, "Name")
input_element.send_keys("Moaiz")
time.sleep(1)
input_element = driver.find_element(By.ID, "Email")
input_element.send_keys("moaizuk@gmail.com")
time.sleep(1)
dropdown_element = driver.find_element(By.ID, "Department")
select_element = Select(dropdown_element)
select_element.select_by_visible_text("IT")
time.sleep(1)
photo_element = driver.find_element(By.ID, "Photo")
photo_element.send_keys("C:\\Users\\Moaiz Mughal\\Downloads\\compngwingbabjj.png")
time.sleep(1)
input_element = driver.find_element(By.ID, "create_btn")
input_element.click()

time.sleep(10)
driver.quit()
