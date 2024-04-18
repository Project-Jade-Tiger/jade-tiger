import { render, screen } from '@testing-library/react';
import App from './App';

describe("App component tests", () => {
    test("should show title all the time", () => {
    
        render(<App/>)

    expect(screen.getByText(/Jade Tiger/i))    
    .toBeDefined()
    })


test("should show 'All' link in the menu", () => {
    
        render(<App/>)

        expect(screen.getByRole('link', {name: /All/i}))
            .toBeDefined()
    })

test("should show 'Home' heading in 'H1' tag", () => {
    
        render(<App/>)

        expect(screen.getByRole('heading', {level: 1, name: /Home/i}))
        .toBeDefined()
    })
})