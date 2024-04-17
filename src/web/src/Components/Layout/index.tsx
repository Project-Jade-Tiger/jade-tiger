import React from 'react';
2
type LayoutProps = {
    children: React.ReactNode;
}

const Layout = ({ children }: LayoutProps) => {
    return (
        <div className="flex flex-col itens-center nt-20"> 
        {children}
    </div>
    );
}

export default Layout;